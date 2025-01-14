using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;


namespace ResourcePathManagementLib
{
    internal static class DefaultResourcePaths
    {
        internal static string StreamingAssetsPath
        {
            get
            {
                return Application.streamingAssetsPath;
            }
        }

        public static class MapGenResourcePathData
        {
            public static string MapGenResourcePathDataBasePath
            {
                get
                {
                    return "LayeredMapGeneration/ResourcePathData/";
                }
            }

            internal static string MapGenResourcePathDataPath
            {
                get
                {
                    return "ResourcePathData.json";
                }
            }
        }
        internal static class InputResourcePathData
        {
            internal static string DefaultInputResourceBasePath
            {
                get
                {
                    return "LayeredMapGeneration/InputData/";
                }
            }
            internal static string DefaultAbstractInputResourcePath
            {
                get
                {
                    return "AbstractInputData.json";
                }
            }
            public static string DefaultBasicPathGenerationInputResourcePath
            {
                get
                {
                    return "BasicPathInputData.json";
                }
            }
            public static string DefaultRegionSelectionInputResourcePath
            {
                get
                {
                    return "RegionSelectionInputData.json";
                }
            }
            public static string DefaultMiddleLayerInputResourcePath
            {
                get
                {
                    return "MiddleLayerInputData.json";
                }
            }
        }
        internal static class OutputResourcePathData
        {
            internal static string DefaultOutputResourceBasePath
            {
                get
                {
                    return "LayeredMapGeneration/OutputData/";
                }
            }

            public static string DefaultBasicPathGenerationOutputResourcePath
            {
                get
                {
                    return "BasicPathOutputData_";
                }
            }
            public static string DefaultRegionSelectionOutputResourcePath
            {
                get
                {
                    return "RegionSelectionOutputData_";
                }
            }
            public static string DefaultMiddleLayerOutputResourcePath
            {
                get
                {
                    return "MiddleLayerOutputData_";
                }
            }
            public static string DefaultTileKindOutputResourcePath
            {
                get
                {
                    return "TileKindOutputData_";
                }
            }
        }
        internal static class AgentBinaryResourcePathData
        {
            internal static string DefaultAgentBinaryResourceBasePath
            {
                get
                {
                    return "LayeredMapGeneration/AgentBinaryData/";
                }
            }

            internal static string DefaultAgentBinaryResourcePath
            {
                get
                {
                    return "LayeredMapGenAgent.exe";
                }
            }
        }
        internal static class GameSaveMetadataPathData
        {
            internal static string DefaultGameSaveMetadataBasePath
            {
                get
                {
                    return "LayeredMapGeneration/GameSaveMetadata/";
                }
            }

            internal static string DefaultGameSaveMetadataPath
            {
                get
                {
                    return "GameSaveMetadata.json";
                }
            }
        }
    }
}