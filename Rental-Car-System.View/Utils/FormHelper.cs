using MaterialSkin;
using MaterialSkin.Controls;

namespace Rental_Car_System.View.Utils
{
    public static class FormHelper
    {
        public static void ShowForm(MaterialForm currentForm, MaterialForm formToOpen, Action<FormClosedEventArgs> formClosedHandler)
        {
            currentForm.Hide();

            formToOpen.FormClosed += (s, arg) => formClosedHandler(arg);

            formToOpen.Show();
        }

        public static void SetTheme(MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
    }
}
