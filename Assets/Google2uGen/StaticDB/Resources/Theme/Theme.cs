//----------------------------------------------
//    Google2u: Google Doc Unity integration
//         Copyright © 2015 Litteratus
//
//        This file has been auto-generated
//              Do not manually edit
//----------------------------------------------

using UnityEngine;
using System.Globalization;

namespace Google2u
{
	[System.Serializable]
	public class ThemeRow : IGoogle2uRow
	{
		public string _Name;
		public string _Nature;
		public string _Lieu;
		public ThemeRow(string __ID, string __Name, string __Nature, string __Lieu) 
		{
			_Name = __Name.Trim();
			_Nature = __Nature.Trim();
			_Lieu = __Lieu.Trim();
		}

		public int Length { get { return 3; } }

		public string this[int i]
		{
		    get
		    {
		        return GetStringDataByIndex(i);
		    }
		}

		public string GetStringDataByIndex( int index )
		{
			string ret = System.String.Empty;
			switch( index )
			{
				case 0:
					ret = _Name.ToString();
					break;
				case 1:
					ret = _Nature.ToString();
					break;
				case 2:
					ret = _Lieu.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "Name":
					ret = _Name.ToString();
					break;
				case "Nature":
					ret = _Nature.ToString();
					break;
				case "Lieu":
					ret = _Lieu.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "Name" + " : " + _Name.ToString() + "} ";
			ret += "{" + "Nature" + " : " + _Nature.ToString() + "} ";
			ret += "{" + "Lieu" + " : " + _Lieu.ToString() + "} ";
			return ret;
		}
	}
	public sealed class Theme : IGoogle2uDB
	{
		public enum rowIds {
	
		};
		public string [] rowNames = {
	
		};
		public System.Collections.Generic.List<ThemeRow> Rows = new System.Collections.Generic.List<ThemeRow>();

		public static Theme Instance
		{
			get { return NestedTheme.instance; }
		}

		private class NestedTheme
		{
			static NestedTheme() { }
			internal static readonly Theme instance = new Theme();
		}

		private Theme()
		{
		}
		public IGoogle2uRow GetGenRow(string in_RowString)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}
		public IGoogle2uRow GetGenRow(rowIds in_RowID)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public ThemeRow GetRow(rowIds in_RowID)
		{
			ThemeRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public ThemeRow GetRow(string in_RowString)
		{
			ThemeRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}

	}

}
