using Systekna.Core;
using Systekna.Core.ValidObject;
using System;
using System.Diagnostics;

namespace Systekna.Application
{
    public class Log : Data.DataBase, IlogEvent
    {
        public string RESPONSAVEL { get; private set; }
        public DateTime? DATAINICIOEVENTO { get; private set; }
        public DateTime? DATAFINALEVENTO { get; private set; }
        public string EVENTO { get; private set; }

        public Log() : base(Framework.StringConection)
        {
            Framework.StringConection = "";
        }

        public void InsertLog(Valid valid)
        {
            RESPONSAVEL = valid.NameUserLogin;
            DATAINICIOEVENTO = valid.DataUserLogin;
            DATAFINALEVENTO = DateTime.Now;
            EVENTO = valid.StringMethod;

            Debug.WriteLine($"EVENTO EXEC: {EVENTO}; logEvento enviado...");
            //ExecDataScalar("", null, System.Data.CommandType.StoredProcedure);
        }
    }
}