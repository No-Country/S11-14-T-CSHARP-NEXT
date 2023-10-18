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
        'green-wiz-1': '#22C008',
        'red-wiz': '#EB4951',
        'red-wiz-1': '#F10A0A',
        'orange-wiz': '#EB4951',
        'blue-wiz': '#1E73BA',
        'gray-wiz': '#86858D',
        'gray-wiz-2': '#19191B',
        'primarywiz':{
          50: "#F1E5FF",
          100: "#E5D1FF",
          200: "#CBA3FF",
          300: "#AE70FF",
          400: "#9442FF",
          500: "#7814FF",
          600: "#5F00DB",
          700: "#4700A3",
          800: "#310070",
          900: "#180038",
          950: "#0B0019"
        },
        'greenwiz':{
          50: "#EDF7F0",
          100: "#DFF1E4",
          200: "#BBE2C6",
          300: "#9BD4AA",
          400: "#78C58C",
          500: "#56B670",
          600: "#419657",
          700: "#317242",
          800: "#204B2C",
          900: "#112717",
          950: "#08120A"
        },
        "redwiz": {
          50: "#FDEDED",
          100: "#FBDADC",
          200: "#F7B5B9",
          300: "#F39196",
          400: "#EF6C73",
          500: "#EB4951",
          600: "#DD1822",
          700: "#A5121A",
          800: "#6E0C11",
          900: "#370609",
          950: "#1C0304"
        },
        "orangewiz": {
          50: "#FDEDED",
          100: "#FBDADC",
          200: "#F7B5B9",
          300: "#F39196",
          400: "#EF6C73",
          500: "#EB4951",
          600: "#DD1822",
          700: "#A5121A",
          800: "#6E0C11",
          900: "#370609",
          950: "#1C0304"
        },
        "bluewiz": {
          50: "#E5F1FB",
          100: "#CAE3F6",
          200: "#9AC9EF",
          300: "#65ACE6",
          400: "#3592DE",
          500: "#1E73BA",
          600: "#185D95",
          700: "#12446E",
          800: "#0C2E4B",
          900: "#061623",
          950: "#030B12"
        },
        "graywiz": {
          50: "#F2F2F3",
          100: "#E7E7E9",
          200: "#CDCDD0",
          300: "#B6B5BA",
          400: "#9E9DA4",
          500: "#86858D",
          600: "#6B6A71",
          700: "#504F54",
          800: "#343437",
          900: "#1B1B1D",
          950: "#0C0C0D"
        },
        "graywizii": {
          50: "#E7E7E9",
          100: "#CFCFD3",
          200: "#A0A0A7",
          300: "#71717A",
          400: "#45454A",
          500: "#19191B",
          600: "#141415",
          700: "#0F0F10",
          800: "#0A0A0B",
          900: "#050505",
          950: "#020203"
        },
      },
      fontFamily: {
        'pro-display': ['"SF Pro Display"', ...defaultTeme.fontFamily.sans],
        roboto: ['Roboto', ...defaultTeme.fontFamily.sans],
        montserrat: ['Montserrat', ...defaultTeme.fontFamily.sans],
      },
    },
  },
  darkMode: 'class',
  plugins: [nextui()],
};
export default config;
