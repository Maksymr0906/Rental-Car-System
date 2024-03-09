namespace CourseProject.Forms.ApplicationFormStates
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
