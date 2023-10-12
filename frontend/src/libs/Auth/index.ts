import { type GetServerSidePropsContext } from 'next';
import { getServerSession, type NextAuthOptions, type DefaultSession } from 'next-auth';

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
  debug: true,
  providers: [],
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
