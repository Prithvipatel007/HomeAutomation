//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("HomeAutomation.Pages.Entrance.xaml", "Pages/Entrance.xaml", typeof(global::HomeAutomation.Pages.Entrance))]

namespace HomeAutomation.Pages {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Pages\\Entrance.xaml")]
    public partial class Entrance : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.SwitchCell Gate_light;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.SwitchCell Front_gate;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.SwitchCell DoorBell;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Entrance));
            Gate_light = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.SwitchCell>(this, "Gate_light");
            Front_gate = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.SwitchCell>(this, "Front_gate");
            DoorBell = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.SwitchCell>(this, "DoorBell");
        }
    }
}
