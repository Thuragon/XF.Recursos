using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Recursos.App_Code;

namespace XF.Recursos.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuView : ContentPage
	{
        public ListView ListView { get { return lstMenu; } } // mesmo nome que esta no menuView lstMenu
        public MenuView()
        {
            InitializeComponent();

            ObservableCollection<OpcoesMenu> menuItems = new ObservableCollection<OpcoesMenu>();
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Home",
                Icone = "Home.png",
                TargetType = typeof(HomeView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Editor",
                TargetType = typeof(Controllers.EditorView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Controle de Data",
                TargetType = typeof(Controllers.PickerView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "List Picker",
                TargetType = typeof(Controllers.ListPickerView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Stepper",
                TargetType = typeof(Controllers.StepperView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "progresso",
                TargetType = typeof(Controllers.ProgressoView)
            });

            lstMenu.ItemsSource = menuItems;
        }
    }
}