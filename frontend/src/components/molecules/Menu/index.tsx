import UserMenu from '@components/atoms/UserMenu';
import Notification from '@components/atoms/Notification';

const Menu = () => {
  return (
    <div className='flex flex-row items-center'>
      <Notification />
      <UserMenu />
    </div>
  );
};

export default Menu;
