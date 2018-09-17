
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Label labelTitle;

	private global::Gtk.Label nameLabel;

	private global::Gtk.Entry nameEntry;

	private global::Gtk.CheckButton checkbuttonCaoVoi;

	private global::Gtk.CheckButton checkbuttonTayTrang;

	private global::Gtk.CheckButton checkbuttonChupHinhRang;

	private global::Gtk.Label labelTramRang;

	private global::Gtk.ComboBox comboboxTramRang;

	private global::Gtk.Label labelCaoVoi;

	private global::Gtk.Label labelTayTrang;

	private global::Gtk.Label labelChupHinhRang;

	private global::Gtk.Label labelTramRang1;

	private global::Gtk.Button buttonThoat;

	private global::Gtk.Label labelTong;

	private global::Gtk.Entry entryTong;

	private global::Gtk.Button buttonTinhTien;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelTitle = new global::Gtk.Label();
		this.labelTitle.HeightRequest = 44;
		this.labelTitle.Name = "labelTitle";
		this.labelTitle.Xpad = 30;
		this.labelTitle.Xalign = 0F;
		this.labelTitle.LabelProp = global::Mono.Unix.Catalog.GetString("Dental Payment Form");
		this.labelTitle.UseMarkup = true;
		this.labelTitle.Wrap = true;
		this.fixed1.Add(this.labelTitle);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelTitle]));
		w1.X = 148;
		w1.Y = 14;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.nameLabel = new global::Gtk.Label();
		this.nameLabel.Name = "nameLabel";
		this.nameLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Ten Khach Hang:");
		this.fixed1.Add(this.nameLabel);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.nameLabel]));
		w2.X = 15;
		w2.Y = 103;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.nameEntry = new global::Gtk.Entry();
		this.nameEntry.CanFocus = true;
		this.nameEntry.Name = "nameEntry";
		this.nameEntry.IsEditable = true;
		this.nameEntry.InvisibleChar = '•';
		this.fixed1.Add(this.nameEntry);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.nameEntry]));
		w3.X = 131;
		w3.Y = 98;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbuttonCaoVoi = new global::Gtk.CheckButton();
		this.checkbuttonCaoVoi.CanFocus = true;
		this.checkbuttonCaoVoi.Name = "checkbuttonCaoVoi";
		this.checkbuttonCaoVoi.Label = global::Mono.Unix.Catalog.GetString("Cao Voi :");
		this.checkbuttonCaoVoi.DrawIndicator = true;
		this.checkbuttonCaoVoi.UseUnderline = true;
		this.fixed1.Add(this.checkbuttonCaoVoi);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbuttonCaoVoi]));
		w4.X = 23;
		w4.Y = 143;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbuttonTayTrang = new global::Gtk.CheckButton();
		this.checkbuttonTayTrang.CanFocus = true;
		this.checkbuttonTayTrang.Name = "checkbuttonTayTrang";
		this.checkbuttonTayTrang.Label = global::Mono.Unix.Catalog.GetString("Tay Trang :");
		this.checkbuttonTayTrang.DrawIndicator = true;
		this.checkbuttonTayTrang.UseUnderline = true;
		this.fixed1.Add(this.checkbuttonTayTrang);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbuttonTayTrang]));
		w5.X = 25;
		w5.Y = 193;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbuttonChupHinhRang = new global::Gtk.CheckButton();
		this.checkbuttonChupHinhRang.CanFocus = true;
		this.checkbuttonChupHinhRang.Name = "checkbuttonChupHinhRang";
		this.checkbuttonChupHinhRang.Label = global::Mono.Unix.Catalog.GetString("Chup Hinh Rang :");
		this.checkbuttonChupHinhRang.DrawIndicator = true;
		this.checkbuttonChupHinhRang.UseUnderline = true;
		this.fixed1.Add(this.checkbuttonChupHinhRang);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbuttonChupHinhRang]));
		w6.X = 22;
		w6.Y = 251;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelTramRang = new global::Gtk.Label();
		this.labelTramRang.Name = "labelTramRang";
		this.labelTramRang.LabelProp = global::Mono.Unix.Catalog.GetString("Tram Rang");
		this.fixed1.Add(this.labelTramRang);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelTramRang]));
		w7.X = 32;
		w7.Y = 303;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.comboboxTramRang = global::Gtk.ComboBox.NewText();
		this.comboboxTramRang.AppendText(global::Mono.Unix.Catalog.GetString("0"));
		this.comboboxTramRang.AppendText(global::Mono.Unix.Catalog.GetString("1"));
		this.comboboxTramRang.AppendText(global::Mono.Unix.Catalog.GetString("2"));
		this.comboboxTramRang.AppendText(global::Mono.Unix.Catalog.GetString("3"));
		this.comboboxTramRang.AppendText(global::Mono.Unix.Catalog.GetString("4"));
		this.comboboxTramRang.AppendText(global::Mono.Unix.Catalog.GetString("5"));
		this.comboboxTramRang.AppendText("");
		this.comboboxTramRang.Name = "comboboxTramRang";
		this.comboboxTramRang.Active = 5;
		this.fixed1.Add(this.comboboxTramRang);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.comboboxTramRang]));
		w8.X = 123;
		w8.Y = 294;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelCaoVoi = new global::Gtk.Label();
		this.labelCaoVoi.Name = "labelCaoVoi";
		this.labelCaoVoi.LabelProp = global::Mono.Unix.Catalog.GetString("100 $");
		this.fixed1.Add(this.labelCaoVoi);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelCaoVoi]));
		w9.X = 322;
		w9.Y = 140;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelTayTrang = new global::Gtk.Label();
		this.labelTayTrang.Name = "labelTayTrang";
		this.labelTayTrang.LabelProp = global::Mono.Unix.Catalog.GetString("1200 $");
		this.fixed1.Add(this.labelTayTrang);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelTayTrang]));
		w10.X = 317;
		w10.Y = 185;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelChupHinhRang = new global::Gtk.Label();
		this.labelChupHinhRang.Name = "labelChupHinhRang";
		this.labelChupHinhRang.LabelProp = global::Mono.Unix.Catalog.GetString("200 $");
		this.fixed1.Add(this.labelChupHinhRang);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelChupHinhRang]));
		w11.X = 323;
		w11.Y = 234;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelTramRang1 = new global::Gtk.Label();
		this.labelTramRang1.Name = "labelTramRang1";
		this.labelTramRang1.LabelProp = global::Mono.Unix.Catalog.GetString("x 50 $");
		this.fixed1.Add(this.labelTramRang1);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelTramRang1]));
		w12.X = 327;
		w12.Y = 295;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.buttonThoat = new global::Gtk.Button();
		this.buttonThoat.CanFocus = true;
		this.buttonThoat.Name = "buttonThoat";
		this.buttonThoat.UseUnderline = true;
		this.buttonThoat.Label = global::Mono.Unix.Catalog.GetString("Thoat ");
		this.fixed1.Add(this.buttonThoat);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.buttonThoat]));
		w13.X = 59;
		w13.Y = 426;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelTong = new global::Gtk.Label();
		this.labelTong.Name = "labelTong";
		this.labelTong.LabelProp = global::Mono.Unix.Catalog.GetString("Total:");
		this.fixed1.Add(this.labelTong);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelTong]));
		w14.X = 54;
		w14.Y = 361;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entryTong = new global::Gtk.Entry();
		this.entryTong.CanFocus = true;
		this.entryTong.Name = "entryTong";
		this.entryTong.IsEditable = true;
		this.entryTong.InvisibleChar = '•';
		this.fixed1.Add(this.entryTong);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entryTong]));
		w15.X = 302;
		w15.Y = 344;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.buttonTinhTien = new global::Gtk.Button();
		this.buttonTinhTien.CanFocus = true;
		this.buttonTinhTien.Name = "buttonTinhTien";
		this.buttonTinhTien.UseUnderline = true;
		this.buttonTinhTien.Label = global::Mono.Unix.Catalog.GetString("Tinh Tien");
		this.fixed1.Add(this.buttonTinhTien);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.buttonTinhTien]));
		w16.X = 312;
		w16.Y = 415;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 512;
		this.DefaultHeight = 504;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.buttonThoat.Clicked += new global::System.EventHandler(this.OnButtonThoatClicked);
		this.buttonTinhTien.Clicked += new global::System.EventHandler(this.OnButtonTinhTienClicked);
	}
}