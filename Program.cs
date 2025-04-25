using System;
using System.Windows.Forms;
using directory250425.Presenters;
using directory250425.Views;

namespace directory250425
{
  static class Program
  {
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      var form = new MainForm();
      var presenter = new SyncPresenter(form);

      Application.Run(form);
    }
  }
}
