using System;
using Gtk;

namespace AssetStudio.GTK {
    public partial class MainWindow : Window {
        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) 
            : base(builder.GetRawOwnedObject("MainForm"))
        {
            builder.Autoconnect(this);
        }

        // ← 這就是給 Glade 裡 handler="gtk_main_quit" 用的
        protected void gtk_main_quit(object sender, EventArgs e)
        {
            Application.Quit();
        }
    }
}
