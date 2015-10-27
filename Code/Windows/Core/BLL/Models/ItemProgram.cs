
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using DAL;

namespace BLL
{
	public class ItemProgram : _ItemProgram
	{
        /// <summary>
        /// Check if a program entry exits for an item
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="programId"></param>
        /// <returns></returns>
	    public bool CheckIfExists(int itemId, int programId)
        {
            bool exist = false;
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.ItemID.Value = itemId;
            this.Where.ProgramID.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.ProgramID.Value = programId;
            this.Query.Load();
            if (this.DataTable.Rows.Count > 0)
                exist = true;

            return exist;
        }
        /// <summary>
        /// Deletes all teh programs for item
        /// </summary>
        /// <param name="itemId"></param>
        public void DeleteAllProgramsForItem(int itemId)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.ItemID.Value = itemId;
            this.Query.Load();
            foreach (DataRowView dv in this.DataTable.DefaultView)
            {
                this.LoadByPrimaryKey(Convert.ToInt32(dv["ID"]));
                this.MarkAsDeleted();
                this.Save();
            }
        }

	}
}