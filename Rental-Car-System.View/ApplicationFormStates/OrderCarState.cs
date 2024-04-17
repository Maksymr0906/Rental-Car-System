using Rental_Car_System.Forms;
using System;
namespace Rental_Car_System.ApplicationFormStates
{
    public class OrderCarState : IApplicationState
    {
        private readonly ApplicationForm form;

        public OrderCarState(ApplicationForm form)
        {
            this.form = form;
        }

        public void ShowUIElements()
        {
            form.ShowOrderCarUI();
        }
    }
}
