using Ibsys2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ibsys2.Pages.About {
  /// <summary>
  /// Interaktionslogik für About.xaml
  /// </summary>
  public partial class Help : Window {
    public Help() {
      InitializeComponent();
      Kurzhilfe.Text = TranslateService.Class.GetTranslation("KURZHILFE");
      HelpText.Text = TranslateService.Class.GetTranslation("HELPTEXT");
      HierButton.Content = TranslateService.Class.GetTranslation("HIERBUTTON");
      WeitereHilfe.Content = TranslateService.Class.GetTranslation("WEITEREHILFE");
      HILFESEITE.Title = TranslateService.Class.GetTranslation("HILFESEITE");
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
      System.Diagnostics.Process.Start("https://weberniklas.github.io/ibsys/#");
    }
  }
}
