﻿using System;

namespace OpenCvSharp.CPlusPlus.ML
{
    // ReSharper disable InconsistentNaming

#if LANG_JP
    /// <summary>
    /// ML 統計モデルのための基本クラス
    /// </summary>
#else
	/// <summary>
    /// Base class for statistical models in ML
    /// </summary>
#endif
    abstract public class StatModel : Algorithm
	{
        #region Init and Disposal
#if LANG_JP
        /// <summary>
        /// 初期化
        /// </summary>
#else
        /// <summary>
        /// Default constructor
        /// </summary>
#endif
        protected StatModel()
        {
        }

        #endregion

        #region Methods
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public override IntPtr InfoPtr
        {
            get { throw new NotImplementedException(); }
        }
    }
}
