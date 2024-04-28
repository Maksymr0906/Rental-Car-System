﻿using Rental_Car_System.Utils;
using MaterialSkin.Controls;
using Rental_Car_System.ApplicationFormStates;
using Rental_Car_System.Data.Models;
using Rental_Car_System.Data.Utils;
using Rental_Car_System.Data.Repositories;
using System.Text.RegularExpressions;

#nullable disable
namespace Rental_Car_System.Forms
{
    public partial class ApplicationForm : MaterialForm
    {
        private RentalApplication currentApplication;
        private IApplicationState currentState;
        public ApplicationForm()
        {
            InitializeComponent();
            MaterialFormSkinManager.SetTheme(this);
        }

        public ApplicationForm(RentalApplication application) : this()
        {
            currentApplication = application;
            SetState();
            ShowUIElements();
            UpdateFields();
        }

        private void SetState()
        {
            if (currentApplication.Type == RentalApplication.ApplicationType.OrderCar)
            {
                currentState = new OrderCarState(this);
            }
            else if (currentApplication.Type == RentalApplication.ApplicationType.RentEnded)
            {
                currentState = new RentEndedState(this);
            }
        }

        private void ShowUIElements() 
        {
            currentState.ShowUIElements();
        }

        public void ShowOrderCarUI()
        {
            rejectionCommentTextField.Visible = true;
            confirmOrderButton.Visible = true;
            cancelOrderButton.Visible = true;
        }

        public void ShowRentEndedUI()
        {
            isCarDamagedCheckBox.Visible = true;
            sendApplicationButton.Visible = true;
            carDamageFeeLabel.Visible = true;
        }

        private void UpdateFields()
        {
            var order = GetCurrentOrder();
            Text = $"Application: {currentApplication.Type}";
            var clientSurname = RepositoryManager.GetRepo<Client>()
                .GetByFilter(c => c.Id == order.ClientId).Surname;
            var car = RepositoryManager.GetRepo<Car>()
                .GetByFilter(c => c.Id == order.CarId);
            clientSurnameLabel.Text += $"{clientSurname}";
            carModelLabel.Text += $"{car.Model}";
            carDamageFeeLabel.Text += $"{car.Price / Constants.coefficientForCarDamage}";
        }

        private void sendApplicationButton_Click(object sender, EventArgs e)
        {
            var order = GetCurrentOrder();
            UpdateOrderStatus(order, Order.OrderStatus.Closed);

            var car = RepositoryManager.GetRepo<Car>()
                .GetByFilter(c => c.Id == order.CarId);
            car.IsAvailable = true;
            car.IsDamaged = isCarDamagedCheckBox.Checked;
            RepositoryManager.GetRepo<Car>().Update(car);

            if(car.IsDamaged)
            {
                var client = RepositoryManager.GetRepo<Client>()
                    .GetByFilter(c => c.Id == order.ClientId);
                var feeForCarDamage = car.Price / Constants.coefficientForCarDamage;
                client.Balance -= feeForCarDamage;
                RepositoryManager.GetRepo<Client>().Update(client);
            }

            MessageBox.Show("Car rent ended. Client will be notificated");
            Close();
        }

        private void confirmOrderButton_Click(object sender, EventArgs e)
        {
            var order = GetCurrentOrder();
            UpdateOrderStatus(order, Order.OrderStatus.Accepted);

            var client = RepositoryManager.GetRepo<Client>()
                .GetByFilter(c => c.Id == order.ClientId);
            client.Balance -= order.Price;
            RepositoryManager.GetRepo<Client>().Update(client);

            MessageBox.Show("Order confirmed. Client will be notificated.");
            Close();
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            if (rejectionCommentTextField.Text == string.Empty)
            {
                MessageBox.Show("Write the descriptive rejection comment before cancelling order.");
                return;
            }

            var order = GetCurrentOrder();
            UpdateOrderStatus(order, Order.OrderStatus.Declined);

            var car = RepositoryManager.GetRepo<Car>()
                .GetByFilter(o => o.Id == order.CarId);
            car.IsAvailable = true;
            RepositoryManager.GetRepo<Car>().Update(car);

            currentApplication.RejectionComment = rejectionCommentTextField.Text;
            RepositoryManager.GetRepo<RentalApplication>().Update(currentApplication);

            MessageBox.Show("Order cancelled. Client will be notificated.");
            Close();
        }

        private void UpdateOrderStatus(Order order, Order.OrderStatus status)
        {
            order.Status = status;
            RepositoryManager.GetRepo<Order>().Update(order);
        }

        private Order GetCurrentOrder()
        {
            return RepositoryManager.GetRepo<Order>()
                .GetByFilter(o => o.Id == currentApplication.OrderId);
        }
    }
}
