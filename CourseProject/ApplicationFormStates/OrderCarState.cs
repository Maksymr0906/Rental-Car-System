namespace CourseProject.Forms.ApplicationFormStates
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
