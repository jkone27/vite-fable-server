import { defineConfig } from 'vite';
import fable from 'vite-plugin-fable';
import { VitePluginNode, VitePluginNodeConfig } from 'vite-plugin-node';
import { configDefaults } from "vitest/config";

const config : VitePluginNodeConfig = {
  appPath: './src/App.fs',
  adapter: "express",
  tsCompiler: "esbuild",
  exportName: "viteNodeApp"
};

export default defineConfig({
  server: {
    port: 3000
  },
  plugins: [
    fable({
      fsproj: './src/App.fsproj',
      jsx: 'automatic'
    }),
    VitePluginNode(config)
  ],
  test: {
    include: ["**/*.{test,spec}.{js,jsx,ts,tsx,fs}"],
    exclude: [...configDefaults.exclude, "dist", ".idea", ".git", ".cache"],
    environment: "node",
    server: {
      deps: { inline: true },
    }
  },
});