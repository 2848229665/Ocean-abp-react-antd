using Ocean.DataBaselnitUpgradeStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocean.Databaselnit
{
    public class DefaultYpgradeStategy
    {
        private readonly IDataBaseInit _dataBaseInit;
        public DefaultYpgradeStategy(IDataBaseInit dataBaseInit) {
            _dataBaseInit = dataBaseInit;
        }
        public stirng[] UnSupportedUpgradeVersion => new string[] { "2.0.0.0" };

        public void AfterFileUpgrade(DbContent dbContentm, string currentVersion) {

        }
        public void BeforeUpgrade(DbContent dbContentm, string currentVersion)
        {

        }
    }
}
