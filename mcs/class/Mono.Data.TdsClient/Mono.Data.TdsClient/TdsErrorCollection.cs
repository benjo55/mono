//
// Mono.Data.TdsClient.TdsErrorCollection.cs
//
// Author:
//   Tim Coleman (tim@timcoleman.com)
//
// Copyright (C) 2002 Tim Coleman
//

using Mono.Data.TdsClient.Internal;
using System;
using System.Collections;

namespace Mono.Data.TdsClient {
        public class TdsErrorCollection : ICollection, IEnumerable
	{
		#region Fields

		ArrayList list = new ArrayList ();

		#endregion // Fields

		#region Properties

		public int Count {
			get { return list.Count; }
		}

		public TdsError this [int index] {
			get { return (TdsError) list[index]; }
		}

		[System.MonoTODO]
		bool ICollection.IsSynchronized {
			get { throw new NotImplementedException (); }
		}

		[System.MonoTODO]
		object ICollection.SyncRoot {
			get { throw new NotImplementedException (); }
		}

		#endregion // Properties

		#region Methods

		[System.MonoTODO]
		public void CopyTo (Array array, int index)
		{
			throw new NotImplementedException ();
		}

		public IEnumerator GetEnumerator ()
		{
			return list.GetEnumerator ();
		}

		#endregion // Methods
	}
}
