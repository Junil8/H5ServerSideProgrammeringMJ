using Microsoft.AspNetCore.DataProtection;

namespace H5ServerSideProgrammeringMJ.JCodes
{
    public class EncryptionJ
    {
        private readonly IDataProtector _dataProtector;

        public EncryptionJ(IDataProtectionProvider protecter)
        {
            _dataProtector = protecter.CreateProtector("H5ServerSideProgrammeringMJ.Jcodes.EncryptionJ.Julian");
        } // Spørg om dette


        public string EncryptString(string stringValue) => _dataProtector.Protect(stringValue);
        public string DecryptString(string stringvalue) => _dataProtector.Unprotect(stringvalue);

    }
}
