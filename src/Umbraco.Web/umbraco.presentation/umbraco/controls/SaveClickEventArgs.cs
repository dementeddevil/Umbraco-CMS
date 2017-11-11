using System;

namespace umbraco.controls
{
    public class SaveClickEventArgs : EventArgs
    {
        public string Message { get; set; }
        public BasePages.BasePage.speechBubbleIcon IconType { get; set; }

        public SaveClickEventArgs(string message)
        {
            Message = message;
            IconType = umbraco.BasePages.BasePage.speechBubbleIcon.success;
        }
    }
}
