﻿using PokemonShowdown.Forms.PokedexTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PokemonShowdown.Forms
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            HideSubMenus();
            Log.Execute("Application initilizated.");
        }

       private void index_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log.Execute("Application closed.");
        }

        private void btnPokedexTools_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelPokedexToolsSubmenu);
        }

        private void buttonMovesTools_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelMovesTools);
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelTeamsSubmenu);

        }

        private void buttonItemsTools_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelItemsTools);
        }

        Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        #region SubmenuTools
        private void HideSubMenus()
        {
            panelPokedexToolsSubmenu.Visible = false;
            panelMovesTools.Visible = false;
            panelTeamsSubmenu.Visible = false;
            panelItemsTools.Visible = false;
        }


        private void ShowSubmenu(Panel subMenu)
        {
            if (subMenu.Visible != true)
            {
                HideSubMenus();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;

        }
        #endregion

        private void btnShowPokeFromPokedex_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShowPokemonForm());
        }

        private void btnAddPokeToPokedex_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddOrUpdatePokemonForm());
        }

        private void btnUpdatePokeFromPokedex_Click(object sender, EventArgs e)
        {
            new SearchPokemonByName(this, SearchPokemonByName.Update).Show();
        }

        private void btnRemovePokeFromPokedex_Click(object sender, EventArgs e)
        {
            new SearchPokemonByName(this, SearchPokemonByName.Remove).Show();
        }

        
    }
}
