using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data
    float paddleMoveUnitsPerSecond = 10;
    float ballImpulseForce = 200;
    float ballLifeSeconds = 10;
    float minSpawnSeconds = 5;
    float maxSpawnSeconds = 10;
    int numberOfBalls = 25;
    int standardBlockPoints = 15;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public float PaddleMoveUnitsPerSecond
    {
        get { return paddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public float BallImpulseForce
    {
        get { return ballImpulseForce; }    
    }

    /// <summary>
    /// Gets the number of seconds the ball lives
    /// </summary>
    /// <value>ball life seconds</value>
    public float BallLifeSeconds
    {
        get { return ballLifeSeconds; }
    }

    /// <summary>
    /// Gets the minimum number of seconds for a ball spawn
    /// </summary>
    /// <value>minimum spawn seconds</value>
    public float MinSpawnSeconds
    {
        get { return minSpawnSeconds; }
    }

    /// <summary>
    /// Gets the maximum number of seconds for a ball spawn
    /// </summary>
    /// <value>maximum spawn seconds</value>
    public float MaxSpawnSeconds
    {
        get { return maxSpawnSeconds; }
    }

    /// <summary>
    /// Gets the number of balls
    /// </summary>
    public int NumberOfBalls
    {
        get
        {
            return numberOfBalls;
        }
    }

    /// <summary>
    /// Get the amount of points destroying a block is worth
    /// </summary>
    public int StandardBlockPoints
    {
        get
        {
            return standardBlockPoints;
        }
    }

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        StreamReader input = null;

        try
        {
            input = File.OpenText(Path.Combine(
                Application.streamingAssetsPath, ConfigurationDataFileName
            ));

            string keys = input.ReadLine();
            string values = input.ReadLine();

            SetConfigurationDataKeys(values);
        } catch (Exception e)
        {
            Console.Error.WriteLine(e);
        } finally
        {
            if (input != null)
            {
                input.Close();
            }
        }
    }

    #endregion

    #region Methods
    public void SetConfigurationDataKeys(string csvKeys)
    {
        string[] keys = csvKeys.Split(',');

        paddleMoveUnitsPerSecond = float.Parse(keys[0]);
        ballImpulseForce = float.Parse(keys[1]);
        ballLifeSeconds = float.Parse(keys[2]);
        minSpawnSeconds = float.Parse(keys[3]);
        maxSpawnSeconds = float.Parse(keys[4]);
        numberOfBalls = int.Parse(keys[5]);
        standardBlockPoints = int.Parse(keys[6]);
    }

    #endregion
}
