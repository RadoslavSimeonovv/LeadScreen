using System;
using System.Collections.Generic;
using System.Text;

namespace LeadScreen.Services.Contracts
{
    public interface IWriteIntoJsonService
    {
        void Write(object obj, string fileName);
    }
}
