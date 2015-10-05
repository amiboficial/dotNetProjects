using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mx.Amib.Sistemas.Credencializacion.ViewModels
{
    public class LogInViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        private bool _processing;
        public bool IsProcessing { get { return this._processing; } }

        public bool ErrorBlankUserName { get; set; }
        public bool ErrorBlankPassword { get; set; }
        public bool ErrorCredentialsNotFound { get; set; }
        public bool ErrorFetchingData { get; set; }
        public bool ErrorNonApproved { get; set; }
        public bool ErrorIsLockedOut { get; set; }

        public delegate void NonArgsEventHandler();

        public event NonArgsEventHandler Validated;
        public event NonArgsEventHandler ValidationFlagsCleaned;
        public event NonArgsEventHandler ProcessingStarted;
        public event NonArgsEventHandler ProcessingStopped;
        public event NonArgsEventHandler SuccessfulLogIn;
        public event NonArgsEventHandler FailedLogIn;

        public void StartProcessing()
        {
            this._processing = true;
            this.ProcessingStarted();
        }
        public void StopProcessing()
        {
            this._processing = false;
            this.ProcessingStopped();
        }

        public void CleanValidationFlags()
        {
            this.ErrorBlankUserName = false;
            this.ErrorBlankPassword = false;
            this.ErrorCredentialsNotFound = false;
            this.ErrorFetchingData = false;
            this.ErrorNonApproved = false;
            this.ErrorIsLockedOut = false;

            if (this.ValidationFlagsCleaned != null)
            {
                this.ValidationFlagsCleaned();
            }
        }

        public bool Validate()
        {
            bool valid = true;
            this.CleanValidationFlags();

            if (this.UserName == null || this.UserName.Trim() == String.Empty)
            {
                this.ErrorBlankUserName = true;
                valid = false;
            }

            if (this.Password == null || this.Password.Trim() == String.Empty)
            {
                this.ErrorBlankPassword = true;
                valid = false;
            }

            try
            {
                this.Validated();
            }
            catch(NullReferenceException)
            {
            }
            return valid;
        }

        async public void LogIn()
        {
            if (this.Validate())
            {

                this.StartProcessing();
                await Task.Run( () => Thread.Sleep(100) );
                this.StopProcessing();

                try { this.SuccessfulLogIn(); }
                catch (NullReferenceException) { }
            }
            else
            {
                try { this.FailedLogIn(); }
                catch (NullReferenceException) { }
            }
        }
    }
}
