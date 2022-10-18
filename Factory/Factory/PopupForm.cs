using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Factory.Core;

namespace Factory;
public partial class PopupForm : Form
{
    Database DataBase;

    public PopupForm()
    {
        this.DataBase = new Database();
        InitializeComponent();
        this.InitData();
    }

    public PopupForm(Database db)
    {
        this.DataBase = db;
        InitializeComponent();
        this.InitData();
    }

    private void Return_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Add_Click(object sender, EventArgs e)
    {
        if (TypeHolder.SelectedItem != null)
        {
            this.DataBase.addCol((TableHeader)TypeHolder.SelectedItem);
            Close();
        }
    }

    private void InitData()
    {
        TypeHolder.Items.AddRange(new TableHeader[] {
                        new TableHeader("INT"),
                        new TableHeader("DOUBLE"),
                        new TableHeader("CHAR"),
                        new TableHeader("BOOLEAN"),
                    });
    }
}
