import { defineConfig, Plugin } from 'vite';
import fable from 'vite-plugin-fable';
import { VitePluginNode, VitePluginNodeConfig } from 'vite-plugin-node';

const config : VitePluginNodeConfig = {
  appPath: './src/App.fs',
  adapter: "express",
};

export default defineConfig({
  server: {
    watch: {
      usePolling: true,
      depth: 3,
      useFsEvents: true
    }
  },
  plugins: [
    fable({
      fsproj: './src/App.fsproj',
    }),
    VitePluginNode(config)
  ]
});