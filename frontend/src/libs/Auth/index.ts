import { type GetServerSidePropsContext } from 'next';
import { getServerSession, type NextAuthOptions, type DefaultSession } from 'next-auth';
import CredentialsProvider from 'next-auth/providers/credentials';
import httpClient from '@libs/httpClient';

declare module 'next-auth' {
  export interface Session extends DefaultSession {
    user: {
      token: string;
    } & DefaultSession['user'];
  }

  interface User {
    user: {
      token: string;
    };
  }
}

export const authOptions: NextAuthOptions = {
  debug: false,
  providers: [
    CredentialsProvider({
      name: 'credentials',
      credentials: {
        username: { label: 'Username', type: 'text' },
        password: { label: 'Password', type: 'password' },
      },
      async authorize(credentials) {
        const { username, password }: any = credentials;

        try {
          const response = await httpClient.post(`/Auth/Login`, {
            userName: username,
            password,
          });

          if (response.status === 200) {
            const data = await response.data;

            if (data.isValid) {
              return data;
            } else {
              return null;
            }
          }
        } catch (error) {
          console.error('Error during authentication', error);
          return null;
        }
      },
    }),
  ],
  session: {
    strategy: 'jwt',
    maxAge: 30 * 24 * 60 * 60, // 30 days
    updateAge: 24 * 60 * 60, // 24 hours
  },
  callbacks: {
    async jwt({ token, user }) {
      const data = user;

      if (user) {
        token.jwt = data.user.token;
      }

      return token;
    },
    async session({ session, token, user }) {
      return { ...session, token, user };
    },
  },
  secret: process.env.NEXTAUTH_SECRET,
};

export const getServerAuthSession = (ctx: {
  req: GetServerSidePropsContext['req'];
  res: GetServerSidePropsContext['res'];
}) => {
  return getServerSession(ctx.req, ctx.res, authOptions);
};
