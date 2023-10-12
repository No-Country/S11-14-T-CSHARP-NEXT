"use client";
import '@styles/globals.css';
import type { Metadata } from 'next';
import { useSession } from 'next-auth/react';
import NextUIProvider from '@libs/NextUIProvider';
import AuthLayout from '@components/templates/AuthLayout';
import PublicLayout from '@components/templates/PublicLayout';

export const metadata: Metadata = {
  title: 'HotelWiz',
  description: 'Generated by create next app',
}

interface Props {
  children: React.ReactNode
}

const RootLayout = ({children}: Props) => {
  const { data: session } = useSession();

  const isAuth = !!session?.user;


  return (
      <html lang="es">
        <head>
          <link href="https://fonts.cdnfonts.com/css/sf-pro-display" rel="stylesheet" ></link>
          <link href="https://fonts.googleapis.com/css2?family=Oswald:wght@400;500;600;700&family=Roboto:wght@400;500;700;900&display=swap" rel="stylesheet"></link>
        </head>
        <body className='h-screen'>
          <NextUIProvider>
              {isAuth ? (
                <AuthLayout>
                  <main>
                    {children}
                  </main>
                </AuthLayout>
              ) : (
                <PublicLayout>
                  <main>
                    {children}
                  </main>
                </PublicLayout>
              )}
          </NextUIProvider>
        </body>
      </html>
  )
}

export default RootLayout;
