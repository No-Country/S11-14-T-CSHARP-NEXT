"use client";

interface AuthLayoutProps {
    children: React.ReactNode
}

const AuthLayout: React.FC<AuthLayoutProps> = ({children}) => {
  return (
    <main>
        {children}
    </main>
  )
}

export default AuthLayout