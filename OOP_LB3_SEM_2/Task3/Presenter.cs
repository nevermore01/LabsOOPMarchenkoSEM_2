using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Presenter
    {
        private Model model;
        private MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.MyEvent += new EventHandler(mainWindow_myEvent);
        }

        void mainWindow_myEvent(object sender, System.EventArgs e)
        {
            string variable = model.Logic(this.mainWindow.textBox1.Text);

            this.mainWindow.textBox1.Text = variable;
        }
    }
}
