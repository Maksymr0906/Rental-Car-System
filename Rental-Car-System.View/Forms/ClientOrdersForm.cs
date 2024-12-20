﻿using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Rental_Car_System.Data;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Bussiness.Utils;
using Rental_Car_System.View.Utils;

namespace Rental_Car_System.View.Forms
{
    public partial class ClientOrdersForm : MaterialForm
    {
        private Client currentClient;
        private readonly RentalCarContext context;
        private int numberOfPages;
        private int pageNumber;
        public ClientOrdersForm()
        {
            InitializeComponent();
            FormHelper.SetTheme(this);
        }

        public ClientOrdersForm(RentalCarContext context) : this()
        {
            this.context = context;
        }

        public void Initialize(Client client)
        {
            currentClient = client;
			numberOfPages = (int)Math.Ceiling((double)context.Orders
				.Count(o => o.ClientId == currentClient.Id) / Constants.pageSize);
			if (numberOfPages <= 0)
			{
				prevButton.Enabled = false;
				nextButton.Enabled = false;
			}
			ShowOrders();
		}

        private void ShowOrders()
        {
            orderedCarsDataGridView.Rows.Clear();

            var query = context.Orders
              .Where(order => order.ClientId == currentClient.Id)
              .Include(order => order.Car)
              .Include(order => order.RentalApplication)
              .OrderByDescending(it => it.DateCreated)
              .Skip(pageNumber * Constants.pageSize)
              .Take(Constants.pageSize)
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
            currentPageLabel.Text = $"{pageNumber+1}";
        }
    }
}
