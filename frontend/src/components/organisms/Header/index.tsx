import Avatar from "@components/atoms/Avatar";

interface HeaderProps {}

const Header: React.FC<HeaderProps> = () => {
  return (
    <header className="w-full">
      <Avatar />
    </header>
  )
};

export default Header;