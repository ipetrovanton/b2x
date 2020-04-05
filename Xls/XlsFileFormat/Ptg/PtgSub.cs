using System.Diagnostics;
using b2xtranslator.StructuredStorage.Reader;

namespace b2xtranslator.Spreadsheet.XlsFileFormat.Ptg
{
    public class PtgSub : AbstractPtg
    {
        public const PtgNumber ID = PtgNumber.PtgSub;


        public PtgSub(IStreamReader reader, PtgNumber ptgid)
            :
            base(reader, ptgid)
        {
            Debug.Assert(this.Id == ID);
            this.Length = 1;
            this.Data = "-";
            this.type = PtgType.Operator;
            this.popSize = 2; 
        }
    }
}
