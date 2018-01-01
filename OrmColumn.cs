using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceNet.Data.Orm
{
    public class OrmColumn
    {
        #region Variables

        private bool m_autoIncrement = false;
        private bool m_allowNull = true;
        private String m_name;
        private DbType m_type;

        #endregion

        #region Properties

        /// <summary>
        /// Gets a value indicating whether the column automatically increments the value of the column for new
        /// rows added to the table.
        /// </summary>
        public bool AutoIncrement
        {
            get { return m_autoIncrement; }
        }

        // <summary>
        /// Gets a value indicating whether null
        /// values are
        /// allowed in this column for rows belonging to the table.
        /// </summary>
        public bool AllowNull
        {
            get { return m_allowNull; }
        }

        /// <summary>
        /// Gets the name of the column.
        /// </summary>
        public String Name
        {
            get { return m_name; }
        }

        public DbType Type
        {
            get { return m_type; }
        }

        #endregion

        #region Methods


        #endregion

        #region Constructors

        public OrmColumn(String name, DbType dataType)
        {
            m_name = name;
            m_type = dataType;
        }

        public OrmColumn(String name, DbType dataType, bool allowNull) : this(name, dataType)
        {
            m_allowNull = allowNull;
        }

        public OrmColumn(String name, DbType dataType, bool allowNull, bool autoIncrement) : this(name, dataType, allowNull)
        {
            m_autoIncrement = autoIncrement;
        }

        #endregion
    }
}
