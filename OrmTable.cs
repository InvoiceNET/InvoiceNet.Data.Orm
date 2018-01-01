using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceNet.Data.Orm
{
    class OrmTable
    {
        #region Variables

        private String m_name;

        private OrmColumnCollection m_primaryKey;

        #endregion

        #region Properties

        public OrmColumnCollection PrimaryKey
        {
            get
            {
                if (m_primaryKey == null)
                    m_primaryKey = new OrmColumnCollection();
                        
                return m_primaryKey;
            }
        }

        public String Name
        {
            get { return m_name; }
        }

        #endregion

        #region Constructors

        public OrmTable(String tableName)
        {
            m_name = tableName.Trim();
        }

        public OrmTable(String tableName, OrmColumn primaryKey)
        {
            m_name = tableName.Trim();
            m_primaryKey = new OrmColumnCollection();
            m_primaryKey.Add(primaryKey);
        }

        public OrmTable(String tableName, OrmColumnCollection primaryKey)
        {
            m_name = tableName.Trim();
            m_primaryKey = primaryKey;
        }

        #endregion
    }
}
