//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sport.Shared {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class MembershipDetailsPage : global::Sport.Shared.MembershipDetailsXaml {
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Sport.Shared.ProfileStripView profileStack;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Sport.Shared.SportButton btnChallenge;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Sport.Shared.SportButton btnPast;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(MembershipDetailsPage));
            profileStack = this.FindByName<global::Sport.Shared.ProfileStripView>("profileStack");
            btnChallenge = this.FindByName<global::Sport.Shared.SportButton>("btnChallenge");
            btnPast = this.FindByName<global::Sport.Shared.SportButton>("btnPast");
        }
    }
}
