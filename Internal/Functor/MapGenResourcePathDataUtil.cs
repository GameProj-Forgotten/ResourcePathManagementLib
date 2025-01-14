using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResourcePathManagementLib
{
    internal static class MapGenResourcePathDataUtil
    {
        internal static void Init(this MapGenResourcePathData resourcePathData)
        {
            resourcePathData = new MapGenResourcePathData()
            {
                InputResourcePath = new MapGenResourcePathData.InputResourcePathData()
                {
                    InputResourceBasePath = DefaultResourcePaths.InputResourcePathData.DefaultInputResourceBasePath,

                    AbstractInputResourcePath = DefaultResourcePaths.InputResourcePathData.DefaultAbstractInputResourcePath,
                    BasicPathGenerationInputResourcePath = DefaultResourcePaths.InputResourcePathData.DefaultBasicPathGenerationInputResourcePath,
                    RegionSelectionInputResourcePath = DefaultResourcePaths.InputResourcePathData.DefaultRegionSelectionInputResourcePath,
                    MiddleLayerInputResourcePath = DefaultResourcePaths.InputResourcePathData.DefaultMiddleLayerInputResourcePath
                },
                OutputResourcePath = new MapGenResourcePathData.OutputResourcePathData()
                {
                    OutputResourceBasePath = DefaultResourcePaths.OutputResourcePathData.DefaultOutputResourceBasePath,

                    BasicPathGenerationOutputResourcePath = DefaultResourcePaths.OutputResourcePathData.DefaultBasicPathGenerationOutputResourcePath,
                    RegionSelectionOutputResourcePath = DefaultResourcePaths.OutputResourcePathData.DefaultRegionSelectionOutputResourcePath,
                    MiddleLayerOutputResourcePath = DefaultResourcePaths.OutputResourcePathData.DefaultMiddleLayerOutputResourcePath,
                    TileKindOutputResourcePath = DefaultResourcePaths.OutputResourcePathData.DefaultTileKindOutputResourcePath
                },
                AgentBinaryResourcePath = new MapGenResourcePathData.AgentBinaryResourcePathData()
                {
                    AgentBinaryResourceBasePath = DefaultResourcePaths.AgentBinaryResourcePathData.DefaultAgentBinaryResourceBasePath,

                    AgentBinaryResourcePath = DefaultResourcePaths.AgentBinaryResourcePathData.DefaultAgentBinaryResourcePath
                },
                GameSaveMetadataPath = new MapGenResourcePathData.GameSaveMetadataPathData()
                {
                    GameSaveMetadataBasePath = DefaultResourcePaths.GameSaveMetadataPathData.DefaultGameSaveMetadataBasePath,

                    GameSaveMetadataPath = DefaultResourcePaths.GameSaveMetadataPathData.DefaultGameSaveMetadataPath
                }
            };
        }
        internal static void Dispose(this MapGenResourcePathData resourcePathData)
        {
            resourcePathData.InputResourcePath.InputResourceBasePath = null;
            resourcePathData.InputResourcePath.AbstractInputResourcePath = null;
            resourcePathData.InputResourcePath.BasicPathGenerationInputResourcePath = null;
            resourcePathData.InputResourcePath.RegionSelectionInputResourcePath = null;
            resourcePathData.InputResourcePath.MiddleLayerInputResourcePath = null;

            resourcePathData.OutputResourcePath.OutputResourceBasePath = null;
            resourcePathData.OutputResourcePath.BasicPathGenerationOutputResourcePath = null;
            resourcePathData.OutputResourcePath.RegionSelectionOutputResourcePath = null;
            resourcePathData.OutputResourcePath.MiddleLayerOutputResourcePath = null;
            resourcePathData.OutputResourcePath.TileKindOutputResourcePath = null;

            resourcePathData.AgentBinaryResourcePath.AgentBinaryResourceBasePath = null;
            resourcePathData.AgentBinaryResourcePath.AgentBinaryResourcePath = null;

            resourcePathData.GameSaveMetadataPath.GameSaveMetadataBasePath = null;
            resourcePathData.GameSaveMetadataPath.GameSaveMetadataPath = null;
        }
    }
}
