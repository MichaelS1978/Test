using System;
using System.Collections.Generic;

namespace OnkoSoft.Data.Domain
{
    public class ChemotherapyProtocol : OnkoSoftBase
    {
        public virtual bool IsArchived { get; set; }
        public virtual string Schema { get; set; }
        public virtual string DiagnosisGroup { get; set; }
        public virtual string Description { get; set; }
        //TODO: IntMM - wird das Feld wirklich gebraucht?
        public virtual string DescriptionAuto { get; set; }
        public virtual string Source { get; set; }
        public virtual bool BodySurfaceMax2SquareMeter { get; set; }
        public virtual bool IntentionAdjuvant { get; set; }
        public virtual bool IntentionCurative { get; set; }
        public virtual bool IntentionDiagnostic { get; set; }
        public virtual bool IntentionNeoadjuvant { get; set; }
        public virtual bool IntentionPalliative { get; set; }
        public virtual bool IntentionPalliativeFirstLine { get; set; }
        public virtual bool IntentionPalliativeSecondLine { get; set; }
        public virtual bool IntentionPalliativeThirdLine { get; set; }
        public virtual bool IntentionPalliativeFourthLine { get; set; }
        public virtual bool IntentionSymptomatic { get; set; }
        public virtual bool PortNecessary { get; set; }
        public virtual int? RepetitionDay { get; set; }
        public virtual int? ExternalId { get; set; }


        public virtual IList<ChemotherapyProtocolCycle> Cycles { get; set; }

        public virtual IList<ChemotherapyProtocolMedication> Medications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChemotherapyProtocol()
        {
            Cycles = new List<ChemotherapyProtocolCycle>();
            Medications = new List<ChemotherapyProtocolMedication>();

        }

        public virtual string SchemaAndDiagnosisGroup
        {
            get
            {
                return string.Format("{0} - {1}", Schema, DiagnosisGroup);
            }
        }

        public override void CopyTo(OnkoSoftBase copy, bool copyIdentity)
        {
            base.CopyTo(copy, copyIdentity);

            (copy as ChemotherapyProtocol).Schema = Schema;
            (copy as ChemotherapyProtocol).DiagnosisGroup = DiagnosisGroup;
            (copy as ChemotherapyProtocol).Description = Description;
            (copy as ChemotherapyProtocol).DescriptionAuto = DescriptionAuto;
            (copy as ChemotherapyProtocol).Source = Source;
            (copy as ChemotherapyProtocol).BodySurfaceMax2SquareMeter = BodySurfaceMax2SquareMeter;
            (copy as ChemotherapyProtocol).IntentionAdjuvant = IntentionAdjuvant;
            (copy as ChemotherapyProtocol).IntentionCurative = IntentionCurative;
            (copy as ChemotherapyProtocol).IntentionDiagnostic = IntentionDiagnostic;
            (copy as ChemotherapyProtocol).IntentionNeoadjuvant = IntentionNeoadjuvant;
            (copy as ChemotherapyProtocol).IntentionPalliative = IntentionPalliative;
            (copy as ChemotherapyProtocol).IntentionPalliativeFirstLine = IntentionPalliativeFirstLine;
            (copy as ChemotherapyProtocol).IntentionPalliativeSecondLine = IntentionPalliativeSecondLine;
            (copy as ChemotherapyProtocol).IntentionPalliativeThirdLine = IntentionPalliativeThirdLine;
            (copy as ChemotherapyProtocol).IntentionPalliativeFourthLine = IntentionPalliativeFourthLine;
            (copy as ChemotherapyProtocol).IntentionSymptomatic = IntentionSymptomatic;
            (copy as ChemotherapyProtocol).PortNecessary = PortNecessary;
            (copy as ChemotherapyProtocol).RepetitionDay = RepetitionDay;
            (copy as ChemotherapyProtocol).ExternalId = ExternalId;


            (copy as ChemotherapyProtocol).Cycles.Clear();

            foreach (ChemotherapyProtocolCycle cpCyle in Cycles)
            {
                ChemotherapyProtocolCycle newCpCycle = cpCyle.Copy(copyIdentity) as ChemotherapyProtocolCycle;
                newCpCycle.ChemotherapyProtocol = (copy as ChemotherapyProtocol);
                (copy as ChemotherapyProtocol).Cycles.Add(newCpCycle);
            }


            (copy as ChemotherapyProtocol).Medications.Clear();

            foreach (ChemotherapyProtocolMedication chemoProtMed in Medications)
            {
                ChemotherapyProtocolMedication newChemoProtMed = chemoProtMed.Copy(copyIdentity) as ChemotherapyProtocolMedication;
                newChemoProtMed.ChemotherapyProtocol = (copy as ChemotherapyProtocol);
                (copy as ChemotherapyProtocol).Medications.Add(newChemoProtMed);
            }
        }

        public override OnkoSoftBase Copy(bool copyIdentity)
        {
            ChemotherapyProtocol copy = new ChemotherapyProtocol();
            CopyTo(copy, copyIdentity);

            return copy;
        }
    }
}