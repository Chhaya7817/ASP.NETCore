using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kimtoo.DbManager;

namespace NirvanaAppilcation.Orders
{
    [Serializable]
    public class Orders
    {
        private string _symbol = string.Empty;
        private string _side = string.Empty;
        private string _account = string.Empty;
        private double _quantity;
        private double _avgPrice;
        private double _remainingQuantity;
        private string _clOrderID = string.Empty;
        private string _parentCLOrderID = string.Empty;
        private string _stagedOrderID = string.Empty;
        private string _originalCLOrderID = string.Empty;




        public string Symbol
        {

            get => this._symbol;

            set => this._symbol = value;
        }

        public string Side
        {
            get => this._side;
            set => this._side = value;
        }

        public string Account
        {
            get => this._account;
            set => this._account = value;
        }

        public double Quantity
        {
            get => this._quantity;
            set => this._quantity = value;
        }

        public double AvgPrice
        {
            get => this._avgPrice;
            set => this._avgPrice = value;
        }

        public double RemainingQuantity
        {
            get => this._remainingQuantity;
            set => this._remainingQuantity = value;
        }

       // public string OrderStatus
       // {
           // get
         //   {
                string empty = string.Empty;
               // return this._quantity != this._remainingQuantity || this._remainingQuantity == 0.0 ? (this._quantity <= this._remainingQuantity || this._remainingQuantity == 0.0 ? Enums.OrderStatus.Filled.ToString() : Enums.OrderStatus.PartiallyFilled.ToString()) : Enums.OrderStatus.New.ToString();
       //     }
       // }

        public string CLOrderID
        {
            get => this._clOrderID;
            set => this._clOrderID = value;
        }

        public string ParentCLOrderID
        {
            get => this._parentCLOrderID;
            set => this._parentCLOrderID = value;
        }

        public string StagedOrderID
        {
            get => this._stagedOrderID;
            set => this._stagedOrderID = value;
        }

        public string OriginalCLOrderID
        {
            get => this._originalCLOrderID;
            set => this._originalCLOrderID = value;
        }

       
    }
}
