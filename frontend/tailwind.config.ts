import type { Config } from 'tailwindcss';
import { nextui } from '@nextui-org/react';
import defaultTeme from 'tailwindcss/defaultTheme';

const config: Config = {
  content: [
    './src/pages/**/*.{js,ts,jsx,tsx,mdx}',
    './src/components/**/*.{js,ts,jsx,tsx,mdx}',
    './src/app/**/*.{js,ts,jsx,tsx,mdx}',
    './node_modules/@nextui-org/theme/dist/**/*.{js,ts,jsx,tsx}',
  ],
  theme: {
    extend: {
      backgroundImage: {
        'gradient-radial': 'radial-gradient(var(--tw-gradient-stops))',
        'gradient-conic': 'conic-gradient(from 180deg at 50% 50%, var(--tw-gradient-stops))',
        'bg-wiz':
          'linear-gradient(180deg, rgba(30,115,186,0.5) 0%, rgba(30,115,186,0.79) 8%, rgba(30,115,186,0.65) 15%, rgba(30,115,186,0.44) 21%, rgba(30,115,186,0.21) 26%, rgba(30,115,186,0) 33%)',
      },
      colors: {
        primary: '#7814FF',
        'green-wiz': '#56B670',
        'red-wiz': '#EB4951',
        'orange-wiz': '#EB4951',
        'blue-wiz': '#1E73BA',
        'gray-wiz': '#86858D',
      },
      fontFamily: {
        'pro-display': ['"SF Pro Display"', ...defaultTeme.fontFamily.sans],
        Roboto: ['Roboto', ...defaultTeme.fontFamily.sans],
      },
    },
  },
  darkMode: 'class',
  plugins: [nextui()],
};
export default config;
