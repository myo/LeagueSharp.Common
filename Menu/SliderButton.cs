using System.Collections.Generic;

namespace LeagueSharp.Common
{
    using System;

    /// <summary>
    ///     SliderButton Menu implementation.
    /// </summary>
    [Serializable]
    public struct SliderButton
    {
        #region Fields

        /// <summary>
        ///     The maximum value.
        /// </summary>
        public int MaxSliderValue;

        /// <summary>
        ///     The minimum value.
        /// </summary>
        public int MinSliderValue;

        /// <summary>
        ///     The slider value.
        /// </summary>
        private int sliderValue;

        /// <summary>
        ///     The button value.
        /// </summary>
        private bool buttonValue;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Slider" /> struct.
        /// </summary>
        /// <param name="sliderValue">
        ///     The slider value.
        /// </param>
        /// <param name="buttonValue">
        ///     The button value.
        /// </param>
        /// <param name="sliderMinValue">
        ///     The minimum value.
        /// </param>
        /// <param name="sliderMaxValue">
        ///     The maximum value.
        /// </param>
        public SliderButton(int sliderValue = 0, int sliderMinValue = 0, int sliderMaxValue = 100, bool buttonValue = false)
        {
            this.sliderValue = sliderValue;
            this.MaxSliderValue = Math.Max(sliderMaxValue, sliderMinValue);
            this.MinSliderValue = Math.Min(sliderMaxValue, sliderMinValue);
            this.buttonValue = buttonValue;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        public Tuple<int, bool> Value
        {
            get
            {
                return new Tuple<int, bool>(this.sliderValue, this.buttonValue);
            }

            set
            {
                this.sliderValue = value.Item1;
                this.buttonValue = value.Item2;
            }
        }

        #endregion
    }
}
