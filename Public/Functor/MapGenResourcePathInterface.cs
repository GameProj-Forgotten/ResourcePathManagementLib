using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResourcePathManagementLib
{
    public static class MapGenResourcePathInterface
    {
        public static class InputResourcePathData
        {
            public static string AbstractInputResourceFullPath
            {
                get
                {
                    string directoryPath = Path.Combine(DefaultResourcePaths.StreamingAssetsPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.InputResourcePath.InputResourceBasePath);
                    string resultPath = Path.Combine(directoryPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.InputResourcePath.AbstractInputResourcePath);

                    if (string.IsNullOrEmpty(resultPath))
                    {
                        throw new Exception("AbstractInputResourceFullPath is null or empty.");
                    }

                    return resultPath;
                }
            }
            public static string BasicPathGenerationInputResourceFullPath
            {
                get
                {
                    string directoryPath = Path.Combine(DefaultResourcePaths.StreamingAssetsPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.InputResourcePath.InputResourceBasePath);
                    string resultPath = Path.Combine(directoryPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.InputResourcePath.BasicPathGenerationInputResourcePath);

                    if (string.IsNullOrEmpty(resultPath))
                    {
                        throw new Exception("BasicPathGenerationInputResourceFullPath is null or empty.");
                    }

                    return resultPath;
                }
            }
            public static string RegionSelectionInputResourceFullPath
            {
                get
                {
                    string directoryPath = Path.Combine(DefaultResourcePaths.StreamingAssetsPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.InputResourcePath.InputResourceBasePath);
                    string resultPath = Path.Combine(directoryPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.InputResourcePath.RegionSelectionInputResourcePath);

                    if (string.IsNullOrEmpty(resultPath))
                    {
                        throw new Exception("RegionSelectionInputResourceFullPath is null or empty.");
                    }

                    return resultPath;
                }
            }
            public static string MiddleLayerInputResourceFullPath
            {
                get
                {
                    string directoryPath = Path.Combine(DefaultResourcePaths.StreamingAssetsPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.InputResourcePath.InputResourceBasePath);
                    string resultPath = Path.Combine(directoryPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.InputResourcePath.MiddleLayerInputResourcePath);

                    if (string.IsNullOrEmpty(resultPath))
                    {
                        throw new Exception("MiddleLayerInputResourceFullPath is null or empty.");
                    }

                    return resultPath;
                }
            }
        }
        public static class OutputResourcePathData
        {
            public static string BasicPathGenerationOutputResourceFullPath
            {
                get
                {
                    string directoryPath = Path.Combine(DefaultResourcePaths.StreamingAssetsPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.OutputResourcePath.OutputResourceBasePath);
                    string resultPath = Path.Combine(directoryPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.OutputResourcePath.BasicPathGenerationOutputResourcePath);

                    if (string.IsNullOrEmpty(resultPath))
                    {
                        throw new Exception("BasicPathGenerationOutputResourceFullPath is null or empty.");
                    }

                    return resultPath;
                }
            }
            public static string RegionSelectionOutputResourceFullPath
            {
                get
                {
                    string directoryPath = Path.Combine(DefaultResourcePaths.StreamingAssetsPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.OutputResourcePath.OutputResourceBasePath);
                    string resultPath = Path.Combine(directoryPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.OutputResourcePath.RegionSelectionOutputResourcePath);

                    if (string.IsNullOrEmpty(resultPath))
                    {
                        throw new Exception("RegionSelectionOutputResourceFullPath is null or empty.");
                    }

                    return resultPath;
                }
            }
            public static string MiddleLayerOutputResourceFullPath
            {
                get
                {
                    string directoryPath = Path.Combine(DefaultResourcePaths.StreamingAssetsPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.OutputResourcePath.OutputResourceBasePath);
                    string resultPath = Path.Combine(directoryPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.OutputResourcePath.MiddleLayerOutputResourcePath);

                    if (string.IsNullOrEmpty(resultPath))
                    {
                        throw new Exception("MiddleLayerOutputResourceFullPath is null or empty.");
                    }

                    return resultPath;
                }
            }
            public static string TileKindOutputResourceFullPath
            {
                get
                {
                    string directoryPath = Path.Combine(DefaultResourcePaths.StreamingAssetsPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.OutputResourcePath.OutputResourceBasePath);
                    string resultPath = Path.Combine(directoryPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.OutputResourcePath.TileKindOutputResourcePath);

                    if (string.IsNullOrEmpty(resultPath))
                    {
                        throw new Exception("TileKindOutputResourceFullPath is null or empty.");
                    }

                    return resultPath;
                }
            }
        }
        public static class AgentBinaryResourcePathData
        {
            public static string AgentBinaryResourceFullPath
            {
                get
                {
                    string directoryPath = Path.Combine(DefaultResourcePaths.StreamingAssetsPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.AgentBinaryResourcePath.AgentBinaryResourceBasePath);
                    string resultPath = Path.Combine(directoryPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.AgentBinaryResourcePath.AgentBinaryResourcePath);

                    if (string.IsNullOrEmpty(resultPath))
                    {
                        throw new Exception("AgentBinaryResourceFullPath is null or empty.");
                    }

                    return resultPath;
                }
            }
        }
        public static class GameSaveMetadataPathData
        {
            public static string GameSaveMetadataFullPath
            {
                get
                {
                    string directoryPath = Path.Combine(DefaultResourcePaths.StreamingAssetsPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.GameSaveMetadataPath.GameSaveMetadataBasePath);
                    string resultPath = Path.Combine(directoryPath, ChiefResourcePathManager.Instance.MapGenResourcePathData.GameSaveMetadataPath.GameSaveMetadataPath);

                    if (string.IsNullOrEmpty(resultPath))
                    {
                        throw new Exception("GameSaveMetadataFullPath is null or empty.");
                    }

                    return resultPath;
                }
            }
        }

        internal static class MapGenResourcePathData
        {
            internal static string MapGenResourcePathDataFullPath
            {
                get
                {
                    string directoryPath = Path.Combine(DefaultResourcePaths.StreamingAssetsPath, DefaultResourcePaths.MapGenResourcePathData.MapGenResourcePathDataBasePath);
                    return Path.Combine(directoryPath, DefaultResourcePaths.MapGenResourcePathData.MapGenResourcePathDataPath);
                }
            }
        }
    }
}