using Rental_Car_System.Data.Models;
using Rental_Car_System.View.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.Data;
using Microsoft.EntityFrameworkCore;
using Rental_Car_System.Exceptions;
using Rental_Car_System.Bussiness.Utils;
using Rental_Car_System.Bussiness.Services;
using Rental_Car_System.View;

namespace Rental_Car_System.Forms
{
    public partial class AdministratorForm : MaterialForm
    {
        private readonly RentalCarContext context;
        private readonly OrderService orderService;
        private readonly RentalApplicationService rentalApplicationService;
		private readonly IUnitOfWork unitOfWork;
		private readonly int numberOfPages;
        private int pageNumber = 0;
        private IFormFactory formFactory;
        public AdministratorForm()
        {
            InitializeComponent();
            FormHelper.SetTheme(this);
        }

        public AdministratorForm(RentalCarContext context, OrderService orderService,
            RentalApplicationService rentalApplicationService,
            IUnitOfWork unitOfWork) : this()
        {
            this.orderService = orderService;
            this.rentalApplicationService = rentalApplicationService;
			this.unitOfWork = unitOfWork;
			this.context = context;

			numberOfPages = (int)Math.Ceiling((double)context.Orders.Count(o => 
                o.Status == Order.OrderStatus.Processing || o.Status == Order.OrderStatus.Ended) / Constants.pageSize);
            if (numberOfPages <= 0)
            {
                prevButton.Enabled = false;
                nextButton.Enabled = false;
            }
            ShowOrders();
        }

		public void Initialize(IFormFactory formFactory)
        {
            this.formFactory = formFactory;
        }

        private void ShowOrders()
        {
            ordersDataGridView.Rows.Clear();

            var result = context.Orders.Where(o => o.Status == Order.OrderStatus.Processing || o.Status == Order.OrderStatus.Ended)
                .Include(order => order.Car)
                .Include(order => order.Client)
                .OrderByDescending(it => it.DateCreated)
                .Skip(pageNumber * Constants.pageSize)
                .Take(Constants.pageSize)
                .Select(order => new
                {
                    OrderId = order.Id,
                    Client = new
                    {
                        order.Client.Name,
                        order.Client.Surname,
                    },
                    Car = new
                    {
                        order.Car.Model,
                        order.Car.Color,
                    },
                    order.DateCreated,
                    order.EndRentDate,
                    order.Price
                }
            ).ToList();

            result.ForEach(it =>
            {
                ordersDataGridView.Rows.Add(it.OrderId, it.Client.Name, it.Client.Surname, it.Car.Model,
                    it.Car.Color, it.DateCreated.ToShortDateString(), it.EndRentDate.ToShortDateString(), it.Price);
            });
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            FormHelper.ShowForm(this, new AddCarForm(), (e) =>
            {
                Show();
            });
        }

        private async void CreateApplicationButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedOrderId = GetSelectedOrderId();
                await rentalApplicationService.CreateApplicationByOrderId(selectedOrderId);
                var application = await unitOfWork.RentalApplicationRepository.GetByFilterAsync(a => a.OrderId == selectedOrderId);

                var applicationForm = formFactory.CreateApplicationForm();
                applicationForm.Initialize(application);

                FormHelper.ShowForm(this, applicationForm, (e) =>
                {
                    ShowOrders();
                    Show();
                });
            }
            catch (NoAvailableOrdersException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private Guid GetSelectedOrderId()
        {
            if (ordersDataGridView.CurrentRow is null)
            {
                throw new NoAvailableOrdersException("There are no available orders now.");
            }
            return Guid.Parse(ordersDataGridView.CurrentRow.Cells[0].Value.ToString());
        }

        private async void skipOrderTimeButton_Click(object sender, EventArgs e)
        {
            await orderService.SkipOrderTime();
            ShowOrders();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            pageNumber = pageNumber > 0 ? pageNumber - 1 : numberOfPages - 1;
            ShowOrders();
            UpdateCurrentPageLabel();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            pageNumber = pageNumber == numberOfPages - 1 ? 0 : pageNumber + 1;
            ShowOrders();
            UpdateCurrentPageLabel();
        }

        private void UpdateCurrentPageLabel()
        {
            currentPageLabel.Text = $"{pageNumber + 1}";
        }
    }
}
