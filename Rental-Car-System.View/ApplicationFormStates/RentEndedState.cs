using Rental_Car_System.Forms;

namespace Rental_Car_System.ApplicationFormStates
{
    public class RentEndedState : IApplicationState
    {
        private readonly ApplicationForm form;

        public RentEndedState(ApplicationForm form)
        {
            this.form = form;
        }

        public void ShowUIElements()
        {
            form.ShowRentEndedUI();
        }
    }
}
