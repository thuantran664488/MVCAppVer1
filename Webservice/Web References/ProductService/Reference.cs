﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Webservice.ProductService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ProductSvcSoap", Namespace="http://tempuri.org/")]
    public partial class ProductSvc : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetProductsOperationCompleted;
        
        private System.Threading.SendOrPostCallback SearchProductsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ProductSvc() {
            this.Url = global::Webservice.Properties.Settings.Default.Webservice_ProductService_ProductSvc;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetProductsCompletedEventHandler GetProductsCompleted;
        
        /// <remarks/>
        public event SearchProductsCompletedEventHandler SearchProductsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetProducts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ProductDTOResponse GetProducts(int PageSize, int PageIndex) {
            object[] results = this.Invoke("GetProducts", new object[] {
                        PageSize,
                        PageIndex});
            return ((ProductDTOResponse)(results[0]));
        }
        
        /// <remarks/>
        public void GetProductsAsync(int PageSize, int PageIndex) {
            this.GetProductsAsync(PageSize, PageIndex, null);
        }
        
        /// <remarks/>
        public void GetProductsAsync(int PageSize, int PageIndex, object userState) {
            if ((this.GetProductsOperationCompleted == null)) {
                this.GetProductsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductsOperationCompleted);
            }
            this.InvokeAsync("GetProducts", new object[] {
                        PageSize,
                        PageIndex}, this.GetProductsOperationCompleted, userState);
        }
        
        private void OnGetProductsOperationCompleted(object arg) {
            if ((this.GetProductsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductsCompleted(this, new GetProductsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SearchProducts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ProductDTOResponse SearchProducts(int PageSize, int PageIndex, string keyword, double minPrice, double maxPrice) {
            object[] results = this.Invoke("SearchProducts", new object[] {
                        PageSize,
                        PageIndex,
                        keyword,
                        minPrice,
                        maxPrice});
            return ((ProductDTOResponse)(results[0]));
        }
        
        /// <remarks/>
        public void SearchProductsAsync(int PageSize, int PageIndex, string keyword, double minPrice, double maxPrice) {
            this.SearchProductsAsync(PageSize, PageIndex, keyword, minPrice, maxPrice, null);
        }
        
        /// <remarks/>
        public void SearchProductsAsync(int PageSize, int PageIndex, string keyword, double minPrice, double maxPrice, object userState) {
            if ((this.SearchProductsOperationCompleted == null)) {
                this.SearchProductsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchProductsOperationCompleted);
            }
            this.InvokeAsync("SearchProducts", new object[] {
                        PageSize,
                        PageIndex,
                        keyword,
                        minPrice,
                        maxPrice}, this.SearchProductsOperationCompleted, userState);
        }
        
        private void OnSearchProductsOperationCompleted(object arg) {
            if ((this.SearchProductsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchProductsCompleted(this, new SearchProductsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ProductDTOResponse {
        
        private ProductDTO[] listProductsField;
        
        private int totalField;
        
        private int remainField;
        
        /// <remarks/>
        public ProductDTO[] ListProducts {
            get {
                return this.listProductsField;
            }
            set {
                this.listProductsField = value;
            }
        }
        
        /// <remarks/>
        public int Total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }
        
        /// <remarks/>
        public int Remain {
            get {
                return this.remainField;
            }
            set {
                this.remainField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ProductDTO {
        
        private string idField;
        
        private string nameField;
        
        private string urlField;
        
        private double priceField;
        
        private string thumbField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <remarks/>
        public double Price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        public string Thumb {
            get {
                return this.thumbField;
            }
            set {
                this.thumbField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetProductsCompletedEventHandler(object sender, GetProductsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProductsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProductDTOResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProductDTOResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SearchProductsCompletedEventHandler(object sender, SearchProductsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchProductsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchProductsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProductDTOResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProductDTOResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591