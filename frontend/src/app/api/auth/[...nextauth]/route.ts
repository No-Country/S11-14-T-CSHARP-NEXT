import NextAuth from "next-auth";
import CredentialsProvider from "next-auth/providers/credentials";
import axios from "axios";

interface CredentialsData{
  username: string;
  password: string;
  redirect: string;
  callbackUrl: string;
  csrfToken: string;
  json: string;
}

interface User {
    name: string | null;
    email: string;
    image: string;
    token: string;
}

const handler = NextAuth({
  providers: [
    CredentialsProvider({
      name: "Credentials",
      credentials: {
        username: { label: "Username", type: "text", placeholder: "jsmith" },
        password: { label: "Password", type: "password" },
      },
      // @ts-ignore: Unreachable code error
      async authorize(credentials: CredentialsData, req): Promise<User | null>{

        console.log('Credentials: ', credentials);
        if (!credentials) return null;

        const { username, password } = credentials;
        if (!username || !password) {
          throw new Error("Todos los campos son obligatorios");
        }

        const apiResponse = await axios.post('http://hotelwiz.somee.com/api/Auth/Login', { userName: username, password } );
        
        if(!apiResponse.data.isValid){
            throw new Error("Usuario y/o password incorrectos.");
        }

        const user = {
            name: apiResponse.data.fullName,
            email: String(username),
            image: apiResponse.data.imageUrl,
            token: apiResponse.data.token,
        };

        return user;
      },
    }),
  ],
  pages: {
    signIn: "/login",
  },
});

export { handler as GET, handler as POST };
