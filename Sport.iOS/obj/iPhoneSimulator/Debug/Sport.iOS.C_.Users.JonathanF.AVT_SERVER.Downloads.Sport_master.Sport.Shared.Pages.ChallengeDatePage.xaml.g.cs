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
    
    
    public partial class ChallengeDatePage : global::Sport.Shared.ChallengeDateXaml {
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.ScrollView scrollView;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Sport.Shared.ChallengeProfileStripView profile;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.DatePicker datePicker;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.TimePicker timePicker;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Sport.Shared.SportButton btnChallenge;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(ChallengeDatePage));
            scrollView = this.FindByName<global::Xamarin.Forms.ScrollView>("scrollView");
            profile = this.FindByName<global::Sport.Shared.ChallengeProfileStripView>("profile");
            datePicker = this.FindByName<global::Xamarin.Forms.DatePicker>("datePicker");
            timePicker = this.FindByName<global::Xamarin.Forms.TimePicker>("timePicker");
            btnChallenge = this.FindByName<global::Sport.Shared.SportButton>("btnChallenge");
        }
    }
}