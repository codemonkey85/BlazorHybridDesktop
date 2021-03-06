using AppKit;
using Foundation;

namespace BlazorHybridDesktop.macOS
{
    [Register("AppDelegate")]
    public class AppDelegate : Xamarin.Forms.Platform.MacOS.FormsApplicationDelegate
    {
        public AppDelegate()
        {
            NSWindowStyle style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;
            CoreGraphics.CGRect rect = new CoreGraphics.CGRect(200, 1000, 1024, 768);
            MainWindow = new NSWindow(rect, style, NSBackingStore.Buffered, false)
            {
                Title = GlobalConstants.AppName,
                TitleVisibility = NSWindowTitleVisibility.Visible,
            };
        }

        public override NSWindow MainWindow { get; }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Menu options to make it easy to press cmd+q to quit the app
            NSApplication.SharedApplication.MainMenu = MakeMainMenu();

            Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            base.DidFinishLaunching(notification);
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }

        private NSMenu MakeMainMenu()
        {
            // top bar app menu
            NSMenu menubar = new NSMenu();
            NSMenuItem appMenuItem = new NSMenuItem();
            menubar.AddItem(appMenuItem);

            NSMenu appMenu = new NSMenu();
            appMenuItem.Submenu = appMenu;

            // add separator
            NSMenuItem separator = NSMenuItem.SeparatorItem;
            appMenu.AddItem(separator);

            // add quit menu item
            string quitTitle = $"Quit {"BlazorHybridDesktop.macOS"}";
            NSMenuItem quitMenuItem = new NSMenuItem(quitTitle, "q", delegate
            {
                NSApplication.SharedApplication.Terminate(menubar);
            });
            appMenu.AddItem(quitMenuItem);

            return menubar;
        }
    }
}
