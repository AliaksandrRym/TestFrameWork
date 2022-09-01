namespace UiGlobalQAPart.Pages
{
    using System;
    using TestFrameWork.DriverCore;

    public class BasePage
    {
        protected T  CreatePageInstance <T>() => (T)Activator.CreateInstance(typeof(T));
    }
}
