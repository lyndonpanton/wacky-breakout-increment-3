﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    #region Fields
    public static ConfigurationData configurationData;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public static float PaddleMoveUnitsPerSecond
    {
        get { return configurationData.PaddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the ball impulse force
    /// </summary>
    /// <value>ball impulse force</value>
    public static float BallImpulseForce
    {
        get { return configurationData.BallImpulseForce; }
    }

    /// <summary>
    /// Gets the number of seconds the ball lives
    /// </summary>
    /// <value>ball life seconds</value>
    public static float BallLifeSeconds
    {
        get { return configurationData.BallLifeSeconds; }
    }

    /// <summary>
    /// Gets the minimum number of seconds for a ball spawn
    /// </summary>
    /// <value>minimum spawn seconds</value>
    public static float MinSpawnSeconds
    {
        get { return configurationData.MinSpawnSeconds; }
    }

    /// <summary>
    /// Gets the maximum number of seconds for a ball spawn
    /// </summary>
    /// <value>maximum spawn seconds</value>
    public static float MaxSpawnSeconds
    {
        get { return configurationData.MaxSpawnSeconds; }
    }

    /// <summary>
    /// Gets the number of balls remaining
    /// </summary>
    public static int NumberOfBalls
    {
        get
        {
            return configurationData.NumberOfBalls;
        }
    }

    /// <summary>
    /// Get the amount of points destroying a block is worth
    /// </summary>
    public static int StandardBlockPoints
    {
        get
        {
            return configurationData.StandardBlockPoints;
        }
    }

    #endregion

    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }
}
