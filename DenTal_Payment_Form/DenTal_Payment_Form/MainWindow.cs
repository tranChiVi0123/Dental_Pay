using System;
using System.Windows.Input;
using System.Windows.Forms;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Gtk.Application.Quit();
        a.RetVal = true;
    }
   
	protected void OnButtonThoatClicked(object sender, EventArgs e)
	{
		Gtk.Application.Quit();
	}

	protected void OnButtonTinhTienClicked(object sender, EventArgs e)
	{   
		string mess = nameEntry.Text.ToString();
		if(mess==""){
			MessageBox.Show("Yeu cau nhap ten");
		}
		int tongTien = 0;
		if(checkbuttonCaoVoi.Active){
			tongTien = tongTien + 100;
		}
		if(checkbuttonTayTrang.Active){
			tongTien = tongTien + 1200;
		}
		if(checkbuttonChupHinhRang.Active){
			tongTien = tongTien + 200;
		}
		int soRang = comboboxTramRang.Active;
		tongTien = tongTien + soRang * 50;
		entryTong.Text = tongTien.ToString();
      
	}

}
