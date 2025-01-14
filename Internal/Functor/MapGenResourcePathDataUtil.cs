using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResourcePathManagementLib
{
    /// <summary>
    /// This class is a static class that contains the utility methods for the MapGenResourcePathData struct.
    /// </summary>
    internal static class MapGenResourcePathDataUtil
    {
        internal static void Init(this MapGenResourcePathData resourcePathData)
        {
            resourcePathData.InputResourcePath = new MapGenResourcePathData.InputResourcePathData()
            {
                InputResourceBasePath = DefaultMapGenResourcePaths.InputResourcePathData.DefaultInputResourceBasePath,

                AbstractInputResourcePath = DefaultMapGenResourcePaths.InputResourcePathData.DefaultAbstractInputResourcePath,
                BasicPathGenerationInputResourcePath = DefaultMapGenResourcePaths.InputResourcePathData.DefaultBasicPathGenerationInputResourcePath,
                RegionSelectionInputResourcePath = DefaultMapGenResourcePaths.InputResourcePathData.DefaultRegionSelectionInputResourcePath,
                MiddleLayerInputResourcePath = DefaultMapGenResourcePaths.InputResourcePathData.DefaultMiddleLayerInputResourcePath
            };
            resourcePathData.OutputResourcePath = new MapGenResourcePathData.OutputResourcePathData()
            {
                OutputResourceBasePath = DefaultMapGenResourcePaths.OutputResourcePathData.DefaultOutputResourceBasePath,

                BasicPathGenerationOutputResourcePath = DefaultMapGenResourcePaths.OutputResourcePathData.DefaultBasicPathGenerationOutputResourcePath,
                RegionSelectionOutputResourcePath = DefaultMapGenResourcePaths.OutputResourcePathData.DefaultRegionSelectionOutputResourcePath,
                MiddleLayerOutputResourcePath = DefaultMapGenResourcePaths.OutputResourcePathData.DefaultMiddleLayerOutputResourcePath,
                TileKindOutputResourcePath = DefaultMapGenResourcePaths.OutputResourcePathData.DefaultTileKindOutputResourcePath
            };
            resourcePathData.AgentBinaryResourcePath = new MapGenResourcePathData.AgentBinaryResourcePathData()
            {
                AgentBinaryResourceBasePath = DefaultMapGenResourcePaths.AgentBinaryResourcePathData.DefaultAgentBinaryResourceBasePath,

                AgentBinaryResourcePath = DefaultMapGenResourcePaths.AgentBinaryResourcePathData.DefaultAgentBinaryResourcePath
            };
            resourcePathData.GameSaveMetadataPath = new MapGenResourcePathData.GameSaveMetadataPathData()
            {
                GameSaveMetadataBasePath = DefaultMapGenResourcePaths.GameSaveMetadataPathData.DefaultGameSaveMetadataBasePath,

                GameSaveMetadataPath = DefaultMapGenResourcePaths.GameSaveMetadataPathData.DefaultGameSaveMetadataPath
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
