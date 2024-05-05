using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Rental_Car_System.Data;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Repositories;
using Rental_Car_System.Utils;

namespace Rental_Car_System.View.Forms
{
    public partial class ClientOrdersForm : MaterialForm
    {
        private readonly Client currentClient;
        public ClientOrdersForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public ClientOrdersForm(RentalCarContext context, Client client) : this()
        {
            currentClient = client;

            //var orders = RepositoryManager.GetRepo<Order>().GetAll(o => o.ClientId == currentClient.Id).ToList();
            //foreach (var order in orders)
            //{
            //    var orderId = order.Id;
            //    var application = RepositoryManager.GetRepo<RentalApplication>().GetByFilter(a => a.OrderId == orderId);
            //    var car = RepositoryManager.GetRepo<Car>()
            //        .GetByFilter(c => c.Id == order.CarId);
            //    orderedCarsDataGridView.Rows.Add(car.Id, car.Model, car.Brand, car.Color, order.Price, order.Status, application?.RejectionComment ?? string.Empty);
            //}

            var query = context.Orders
              .Where(order => order.ClientId == currentClient.Id)
              .Include(order => order.Car)
              .Include(order => order.RentalApplication)
              .OrderByDescending(it => it.DateCreated)
              .Select(order => new
              {
                  OrderId = order.Id,
                  Car = new
                  {
                      order.Car.Id,
                      order.Car.Model,
                      order.Car.Brand,
                      order.Car.Color,
                  },
                  order.Price,
                  order.Status,
                  RejectionComment = order.RentalApplication.RejectionComment ?? string.Empty,
                  order.DateCreated,
                  order.EndRentDate
              }).ToList();

            query.ForEach(it =>
            {
                orderedCarsDataGridView.Rows.Add(it.Car.Id, it.Car.Model, it.Car.Brand, 
                    it.Car.Color, it.Price, it.Status, it.RejectionComment, it.DateCreated.ToShortDateString(), it.EndRentDate.ToShortDateString());
            });
        }
    }
}
