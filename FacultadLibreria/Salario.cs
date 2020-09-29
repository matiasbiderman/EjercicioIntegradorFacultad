using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadLibreria
{
    class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        public double GetSalarioNeto()
        {

        }

        public Salario(double )
        {

        }
        public double Bruto
        {
            get
            {
                return this._bruto;
            }
            set
            {
                this._bruto = value;
            }
        }
        public string CodigoTransferencia
        {
            get
            {
                return this._codigoTransferencia;
            }
            set
            {
                this._codigoTransferencia = value;
            }
        }
        public double Descuentos
        {
            get
            {
                return this._descuentos;
            }
            set
            {
                this._descuentos = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this._fecha;
            }
            set
            {
                this._fecha = value;
            }
        }



    }
}
