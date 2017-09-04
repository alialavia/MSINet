using MSINet.Interop;
using System;

namespace MSINet
{
    [Serializable]
    internal class MSIException : Exception
    {
        private MsiExitCodes returnValue;

        public MSIException(MsiExitCodes returnValue) : base("MSIError : " + returnValue.ToString())
        {
            this.returnValue = returnValue;
        }

        public MsiExitCodes ReturnValue => this.returnValue;
    }
}