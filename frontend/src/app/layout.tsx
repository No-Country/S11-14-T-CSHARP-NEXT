import '@styles/globals.css'
import type { Metadata } from 'next'
import NextUIProvider from '@libs/NextUIProvider';

export const metadata: Metadata = {
  title: 'HotelWiz',
  description: 'Generated by create next app',
}

interface Props {
  children: React.ReactNode
}

const RootLayout = ({children}: Props) => {
  return (
      <html lang="es">
        <head>
          <link href="https://fonts.cdnfonts.com/css/sf-pro-display" rel="stylesheet" ></link>
          <link href="https://fonts.googleapis.com/css2?family=Oswald:wght@400;500;600;700&family=Roboto:wght@400;500;700;900&display=swap" rel="stylesheet"></link>
        </head>
        <body className='h-screen'>
          <NextUIProvider>
            {children}
          </NextUIProvider>
        </body>
      </html>
  )
}

export default RootLayout;
