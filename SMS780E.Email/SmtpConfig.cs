using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMS780E.Email
{
    public class SmtpConfig
    {
        public string host;
        public int port;
        public bool useSsl;
        public CancellationToken cancellationToken = default(CancellationToken);

        public string username;
        public string password;

    }
}
