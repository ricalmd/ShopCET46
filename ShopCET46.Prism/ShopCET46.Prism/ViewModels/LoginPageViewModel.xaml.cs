using Prism.Navigation;
using System.Reflection;
using Xamarin.Forms;

namespace ShopCET46.Prism.ViewModels
{
    public partial class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Login Page";
        }
    }
}
