using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Mx.Amib.Sistemas.Credencializacion.Properties;
using Mx.Amib.Sistemas.Credencializacion.ViewModels;

namespace Mx.Amib.Sistemas.Credencializacion.Views
{
    public partial class LogInForm : Form
    {
        LogInViewModel logInViewModel;

        public LogInForm()
        {
            InitializeComponent();
            //utiliza el icono del archivo de recursos
            this.Icon = Resources.IconoAplicacion;

            //instancía el view model
            this.logInViewModel = new LogInViewModel();

            //aplica "rendereos" adicionales
            this.RenderInitialCustomColors();
            this.RenderProcessing();

            //bindea eventos
            this.logInViewModel.ProcessingStarted += (() => this.RenderProcessing());
            this.logInViewModel.ProcessingStopped += (() => this.RenderProcessing());
            this.logInViewModel.ValidationFlagsCleaned += (() => this.RenderValidated());
            this.logInViewModel.Validated += (() => this.RenderValidated());

            this.logInViewModel.SuccessfulLogIn += (() => {
                MainForm nextView = new MainForm();
                nextView.Show();
            });
        }

        #region Rendereos

        private void RenderInitialCustomColors()
        {
            this.BackColor = ColorTranslator.FromHtml(Resources.ColorBackgroundWindow);

            this.txtUsername.BackColor = ColorTranslator.FromHtml(Resources.ColorBackgroundTextbox);
            this.txtUsername.ForeColor = ColorTranslator.FromHtml(Resources.ColorForegroundTextbox);
            this.txtPassword.BackColor = ColorTranslator.FromHtml(Resources.ColorBackgroundTextbox);
            this.txtPassword.ForeColor = ColorTranslator.FromHtml(Resources.ColorForegroundTextbox);

            this.pnlState.BackColor = ColorTranslator.FromHtml(Resources.ColorBackgroundInfoStatePanel);
            this.pnlState.ForeColor = ColorTranslator.FromHtml(Resources.ColorForegroundInfoStatePanel);
        }

        private void RenderProcessing()
        {
            if(this.logInViewModel.IsProcessing)
            {
                this.pbarProc.Visible = true;
                this.lblMessage.Text = Resources.MessageLogInProcessing;
                this.DisableAllInputs();
            }
            else
            {
                this.pbarProc.Visible = false;
                this.lblMessage.Text = Resources.MessageLogInWelcome;
                this.EnableAllInputs();
            }
        }

        private void RenderValidated()
        {
            bool valid = true;

            this.RenderInitialCustomColors();
            this.lblMessage.Text = String.Empty;

            if(this.logInViewModel.ErrorBlankUserName)
            {
                this.txtUsername.BackColor = ColorTranslator.FromHtml(Resources.ColorBackgroundErrorTextbox);
                this.txtUsername.ForeColor = ColorTranslator.FromHtml(Resources.ColorForegroundErrorTextbox);

                this.pnlState.BackColor = ColorTranslator.FromHtml(Resources.ColorBackgroundErrorStatePanel);
                this.pnlState.ForeColor = ColorTranslator.FromHtml(Resources.ColorForegroundErrorStatePanel);

                this.lblMessage.Text += Resources.MessageLogInErrorBlankUserName + "; ";

                valid = false;
            }
            if(this.logInViewModel.ErrorBlankPassword)
            {
                this.txtPassword.BackColor = ColorTranslator.FromHtml(Resources.ColorBackgroundErrorTextbox);
                this.txtPassword.ForeColor = ColorTranslator.FromHtml(Resources.ColorForegroundErrorTextbox);

                this.pnlState.BackColor = ColorTranslator.FromHtml(Resources.ColorBackgroundErrorStatePanel);
                this.pnlState.ForeColor = ColorTranslator.FromHtml(Resources.ColorForegroundErrorStatePanel);

                this.lblMessage.Text += Resources.MessageLogInErrorBlankPassword + "; ";

                valid = false;
            }
            if(this.logInViewModel.ErrorCredentialsNotFound)
            {
                this.txtUsername.BackColor = ColorTranslator.FromHtml(Resources.ColorBackgroundErrorTextbox);
                this.txtUsername.ForeColor = ColorTranslator.FromHtml(Resources.ColorForegroundErrorTextbox);
                this.txtPassword.BackColor = ColorTranslator.FromHtml(Resources.ColorBackgroundErrorTextbox);
                this.txtPassword.ForeColor = ColorTranslator.FromHtml(Resources.ColorForegroundErrorTextbox);

                this.pnlState.BackColor = ColorTranslator.FromHtml(Resources.ColorBackgroundErrorStatePanel);
                this.pnlState.ForeColor = ColorTranslator.FromHtml(Resources.ColorForegroundErrorStatePanel);

                this.lblMessage.Text += Resources.MessageLogInErrorBlankPassword + "; ";

                valid = false;
            }


            if(valid)
                this.lblMessage.Text = Resources.MessageLogInWelcome;
        }

        private void DisableAllInputs()
        {
            this.txtUsername.Enabled = false;
            this.txtPassword.Enabled = false;
            this.btnLogIn.Enabled = false;
            this.btnExit.Enabled = false;
        }

        private void EnableAllInputs()
        {
            this.txtUsername.Enabled = true;
            this.txtPassword.Enabled = true;
            this.btnLogIn.Enabled = true;
            this.btnExit.Enabled = true;
        }

        #endregion

        #region DataBindings

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            this.logInViewModel.UserName = ((TextBox)sender).Text;
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.logInViewModel.Password = ((TextBox)sender).Text;
        }

        #endregion

        #region Navegacion

        #endregion

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            this.logInViewModel.CleanValidationFlags();
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            this.logInViewModel.CleanValidationFlags();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.logInViewModel.LogIn();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
